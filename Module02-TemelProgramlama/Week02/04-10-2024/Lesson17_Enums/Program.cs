namespace Lesson17_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenderType gender;
            gender=GenderType.Male;
            //Console.WriteLine(gender);

            //if ((int)gender == 1)
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            //if (gender == GenderType.Female)
            //{
            //    Console.WriteLine("Hoş geldiniz");
            //}

            OrderState orderState = OrderState.TeslimEdildi;
            //Siparişiniz kargoya verilmiştir.
            int orderStateInt = (int)orderState;
            //switch (orderStateInt)
            //{
            //    case 0:
            //        Console.WriteLine("Siparişiniz alındı.");
            //        break;

            //    case 1:
            //        Console.WriteLine("Siparişiniz hazırlanıyor.");
            //        break;

            //    case 2:
            //        Console.WriteLine("Siparişiniz kargoya verildi.");
            //        break;

            //    default:
            //        Console.WriteLine("Siparişiniz teslim edildi.");
            //        break;
            //}

            switch (orderState)
            {
                case OrderState.SiparişAlındı:
                    Console.WriteLine("Siparişiniz alındı.");
                    break;

                case OrderState.Hazırlanıyor:
                    Console.WriteLine("Siparişiniz hazırlanıyor.");
                    break;

                case OrderState.KargoyaVerildi:
                    Console.WriteLine("Siparişiniz kargoya verildi.");
                    break;

                default:
                    Console.WriteLine("Siparişiniz teslim edildi.");
                    break;
            }
        }
    }
}
