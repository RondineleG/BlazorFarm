using System.Collections.Generic;

namespace BlazorFarm.Data
{
    public static class Animals
    {
        public static IEnumerable<AnimalInfo> All => new[]
        {

            new AnimalInfo("Cat", "O gato do pátio do celeiro é um alimento básico em muitas fazendas." ) ,
            new AnimalInfo("Chicken", "Fornecendo ovos frescos e cacarejar constante." ) ,
            new AnimalInfo("Cow", "Cow's are the source of milk and beef." ) ,
            new AnimalInfo("Dog", "Todo agricultor precisa de um cachorro confiável para vigiar." ) ,
            new AnimalInfo("Donkey", "O animal confiável pode tornar o trabalho pesado mais fácil." ) ,
            new AnimalInfo("Horse", "Ajude os fazendeiros a cobrir longas distâncias mais rápido. YeeHaw!" ) ,
            new AnimalInfo("Pig", "É divertido ter esses animais bagunçados por perto." ) ,
            new AnimalInfo("Rooster", "Ajudando os agricultores a acordar cedo em todos os lugares." ) ,
            new AnimalInfo("Sheep", "Uma ótima fonte de lã para os invernos frios." )
        };

        public sealed record AnimalInfo(string Name, string Description)
        {
            public string ImageUrl => $"/img/{Name.ToLowerInvariant()}.png";
            public string WavUrl => $"/audio/{Name.ToLowerInvariant()}.wav";
        }
    }
}