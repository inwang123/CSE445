using System;
using System.Collections.Generic;
using System.Threading;

namespace ConsoleApp1
{

    public
        delegate void PriceCutEvent(double roomPrice, Thread agentThread);
    public
        delegate void OrderProcessEvent(Order order, double orderAmount);
    public
        delegate void OrderCreationEvent();

    public
        class MainClass
    {
        public
            static MultiCellBuffer buffer;
        public
            static Thread[] travelAgentThreads;
        public
            static bool hotelThreadRunning = true;

        public
            static void Main(string[] args)
        {
            // Initialize buffer hotel travelagent here
            buffer = new MultiCellBuffer();
            Hotel hotel = new Hotel();
            TravelAgent travelAgent = new TravelAgent();

            // sart hotel thread
            Thread hotelThread = new Thread(new ThreadStart(hotel.HotelFun));
            hotelThread.Start();

            Hotel.PriceCut += new PriceCutEvent(travelAgent.AgentOrder);
            TravelAgent.orderCreation += new OrderCreationEvent(hotel.TakeOrder);
            OrderProcessing.OrderProcess += new OrderProcessEvent(travelAgent.OrderProcessConfirm);

            // start travel agent thread ghere
            travelAgentThreads = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                travelAgentThreads[i] = new Thread(travelAgent.AgentFun);
                travelAgentThreads[i].Name = (i + 1).ToString();
                travelAgentThreads[i].Start();
            }
        }
    }

    // manages buffer
    public class MultiCellBuffer
    {
        // Constants and variables
        private
            const int bufferSize = 3;
        private
            Order[] multiCells;
        public
            static Semaphore getSemaph;
        public
            static Semaphore setSemaph;

        // Constructor
        public
            MultiCellBuffer()
        {
            multiCells = new Order[bufferSize];
            getSemaph = new Semaphore(bufferSize, bufferSize);
            setSemaph = new Semaphore(bufferSize, bufferSize);
        }

        // set data to cell
        public
            void SetOneCell(Order data)
        {
            setSemaph.WaitOne();
            lock (this)
            {
                for (int i = 0; i < bufferSize; i++)
                {
                    if (multiCells[i] == null)
                    {
                        multiCells[i] = data;
                        break;
                    }
                }
            }
            getSemaph.Release();
        }

        // gets data from cell
        public
            Order GetOneCell()
        {
            getSemaph.WaitOne();
            Order result = null;
            lock (this)
            {
                for (int i = 0; i < bufferSize; i++)
                {
                    if (multiCells[i] != null)
                    {
                        result = multiCells[i];
                        multiCells[i] = null;
                        break;
                    }
                }
            }
            setSemaph.Release();
            return result;
        }
    }

    // manage order here
    public class Order
    {

        private
            string senderId;
        private
            long cardNo;
        private
            double unitPrice;
        private
            int quantity;

        public
            Order(string senderId, long cardNo, double unitPrice, int quantity)
        {
            this.senderId = senderId;
            this.cardNo = cardNo;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }
        // getter functions
        public
            string GetSenderId()
        {
            return senderId;
        }

        public
            long GetCardNo()
        {
            return cardNo;
        }

        public
            double GetUnitPrice()
        {
            return unitPrice;
        }

        public
            int GetQuantity()
        {
            return quantity;
        }
    }

    // Class for processing orders
    public class OrderProcessing
    {

        public
            static event OrderProcessEvent OrderProcess;

        // check the validity of credit card here
        public
            static bool CreditCardCheck(long creditCardNumber)
        {
            return creditCardNumber >= 5000 && creditCardNumber <= 7000;
        }

        // calculate order chantge
        public
            static double CalculateCharge(double unitPrice, int quantity)
        {
            Random rnd = new Random();
            double tax = rnd.Next(8, 13) / 100.0;     // Tax between 8% and 12%
            double locationCharge = rnd.Next(20, 81); // Location charge between $20 and $80
            return unitPrice * quantity * (1 + tax) + locationCharge;
        }

        // process order here
        public
            static void ProcessOrder(Order order)
        {
            bool isValidCreditCard = CreditCardCheck(order.GetCardNo());
            if (!isValidCreditCard)
            {
                Console.WriteLine("Invalid credit card number.");
                return;
            }

            double orderAmount = CalculateCharge(order.GetUnitPrice(), order.GetQuantity());
            OrderProcess?.Invoke(order, orderAmount); // invoke event for order processing
        }
    }

    // represents travel agent
    public class TravelAgent
    {
        // create order here
        public
            static event OrderCreationEvent orderCreation;

        public
            void AgentFun()
        {
            while (MainClass.hotelThreadRunning)
            {
                Thread.Sleep(new Random().Next(500, 2000));
                CreateOrder(this.GetType().Name);
            }
        }

        // handle price cut events here
        public
            void AgentOrder(double roomPrice, Thread agentThread)
        {
            Console.WriteLine($ "Agent {agentThread.Name} sees price cut to {roomPrice} and decides to place an order.");
            CreateOrder(agentThread.Name);
        }

        // create an order here
        private
            void CreateOrder(string senderId)
        {
            long cardNo = new Random().Next(5000, 7001); // create random credit card number
            double unitPrice = 100;                      // the default price is 100
            int quantity = new Random().Next(1, 5);      // random # of rooms

            Order order = new Order(senderId, cardNo, unitPrice, quantity);
            MainClass.buffer.SetOneCell(order);
        }

        // Method for confirming order processing
        public
            void OrderProcessConfirm(Order order, double orderAmount)
        {
            Console.WriteLine($ "Order for {order.GetQuantity()} rooms from {order.GetSenderId()} processed. Amount charged: {orderAmount:C}");
        }
    }

    // function that manages a hotel
    public class Hotel
    {

        private
            static double currentRoomPrice = 100; // default room space is 100
        private
            static object priceLock = new object();
        public
            static event PriceCutEvent PriceCut;

        // manage hotel's operation here
        public
            void HotelFun()
        {
            int priceCutCount = 0;
            while (priceCutCount < 10) // price cuts can only go up to 10
            {
                double newPrice = PricingModel(); // get new price
                if (newPrice < currentRoomPrice)
                {
                    PriceCut?.Invoke(newPrice, Thread.CurrentThread); // invoke price cut
                    priceCutCount++;                                   // price cut counts up by 1s
                }
                currentRoomPrice = newPrice; // Update price

                Order order = MainClass.buffer.GetOneCell(); // Get order from buffer
                if (order != null)
                {
                    OrderProcessing.ProcessOrder(order); // Process order
                }

                Thread.Sleep(1000);
            }

            MainClass.hotelThreadRunning = false; // signal hotel thread is no longer running
        }

        private
            double PricingModel()
        {
            Random rnd = new Random();
            double change = rnd.Next(-10, 11); // set a random change
            lock (priceLock)
            {
                currentRoomPrice = Math.Max(80, Math.Min(160, currentRoomPrice + change)); // set range for price
            }
            return currentRoomPrice; // get new price here
        }

        // update room price
        public
            void UpdatePrice(double newRoomPrice)
        {
            lock (priceLock)
            {
                currentRoomPrice = newRoomPrice; // update the currebt price
            }
        }

        // take order here
        public
            void TakeOrder()
        {
            Order order = MainClass.buffer.GetOneCell(); // get order from buffer
            if (order != null)
            {
                OrderProcessing.ProcessOrder(order); // process order
            }
        }
    }
}
