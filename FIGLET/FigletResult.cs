using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FigletResult
{
    public string String { get; set; }
    public bool CharacterError { get; set; }

    public FigletResult(string result, bool characterError)
    {
        String = result;
        CharacterError = characterError;
    }
}

