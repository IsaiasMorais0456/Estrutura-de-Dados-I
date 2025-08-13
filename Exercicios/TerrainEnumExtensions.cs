using System;

public static class TerrainEnumExtensions //Extensão de enumeração para obter cores e caracteres específicos
{
    public static ConsoleColor GetColor(this TerrainEnum terrain) //Método para obter a cor do terreno
    {
        switch (terrain)
        {
            case TerrainEnum.GRASS: return ConsoleColor.Green;
            case TerrainEnum.SAND: return ConsoleColor.Yellow;
            case TerrainEnum.WATER: return ConsoleColor.Blue;
            default: return ConsoleColor.DarkGray; //Cor padrão para terrenos não especificados
        }
    }

    public static char GetChar(this TerrainEnum terrain) //Método para obter o caractere do terreno
    {
        switch (terrain)
        {
            case TerrainEnum.GRASS: return '\u201c'; // “
            case TerrainEnum.SAND: return '\u25cb'; // ○
            case TerrainEnum.WATER: return '\u2248'; // ≈
            default: return '\u25cf';               // ●
        }
    }
}