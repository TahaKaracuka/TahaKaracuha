namespace Lesson15_Struct_Yapilar
{
    public struct SampleStruct
    {
        public int number;
        public string text;
        public void MyMethod()
        {
            Console.WriteLine("Bu metot yapı(struct) içindedir.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class bellekteki HEAP tarafında tutulurken, Struct ise bellekteki STACK tarafında tutulur.
            //Bunun farkı bize şunu anlatır: HEAP tarafındaki refererence  type değişkenler işi bittiğinde yok edilmeyip, Garbage Collector adlı bir mekanizma tarafından bizim kontrolümüz dışında yok edilmeyi beklerler.
            //STACK tarafındaki değişkenler yani value type değişkenler ise, işleri bittiğinde bellekten kendiliğinden yok edilirler.
            //Dolayısıyla bazı durumlarda STRUCT, class kullanımına göre bellek performansı açısından daha kullanışlı olacaktır.
            SampleStruct sampleStruct = new SampleStruct();
            sampleStruct.MyMethod();
        }
    }
}
