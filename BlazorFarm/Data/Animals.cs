using System.Collections.Generic;

namespace BlazorFarm.Data
{
    public static class Animals
    {
        public static IEnumerable<AnimalInfo> All => new[]
        {

            new AnimalInfo("Cat", "O gato do p�tio do celeiro � um alimento b�sico em muitas fazendas." ) ,
            new AnimalInfo("Chicken", "Fornecendo ovos frescos e cacarejar constante." ) ,
            new AnimalInfo("Cow", "Cow's are the source of milk and beef." ) ,
            new AnimalInfo("Dog", "Todo agricultor precisa de um cachorro confi�vel para vigiar." ) ,
            new AnimalInfo("Donkey", "O animal confi�vel pode tornar o trabalho pesado mais f�cil." ) ,
            new AnimalInfo("Horse", "Ajude os fazendeiros a cobrir longas dist�ncias mais r�pido. YeeHaw!" ) ,
            new AnimalInfo("Pig", "� divertido ter esses animais bagun�ados por perto." ) ,
            new AnimalInfo("Rooster", "Ajudando os agricultores a acordar cedo em todos os lugares." ) ,
            new AnimalInfo("Sheep", "Uma �tima fonte de l� para os invernos frios." )
        };

        public sealed record AnimalInfo(string Name, string Description)
        {
            public string ImageUrl => $"/img/{Name.ToLowerInvariant()}.png";
            public string WavUrl => $"/audio/{Name.ToLowerInvariant()}.wav";
        }
    }
}