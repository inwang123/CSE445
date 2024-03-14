using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Pokemon
{
    // NOTE: this is all three of my services stemming, natural hazard and sudoku combined
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string StemText(string textToStem);

        [OperationContract]
        string GetPokemonInfo(int pokemonId);

        [OperationContract]
        int GetRandomPokemonId();

        [OperationContract]
        string GetPokemonImageUrl(int pokemonIndex);
        [OperationContract]
        string GetSudokuPuzzle();

        [OperationContract]
        string[] GetMatrices(string jsonString, int difficulty);

        [OperationContract]
        string[] ParseStringToArray(string input);

        [OperationContract]
        string ArrayToString(string[] array);

        [OperationContract]
        string FormatSudoku(string sudokuString);

    }
}
