namespace SerializationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo of Serialization and Deserialization");
            BinarySerialization binaryserialize = new BinarySerialization();
            //binaryserialize.Serialization();
            BinaryDeSerialization binarydesrialize = new BinaryDeSerialization();
            binarydesrialize.DeSerialization();

        }
    }
}