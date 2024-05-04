namespace AnimalClassAndEdibleInterface
{
    public class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "Chicken: cluck-cluck!";
        }

        public string HowToEat()
        {
            return "Chickens can be fried";
        }
    }
}
