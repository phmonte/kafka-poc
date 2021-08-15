using System;
using App.Producer.Context;
using App.Producer.Model;

namespace App.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new KafkaContext()) {

                var std = new Person()
                {
                    Name = args.Length > 0 ? args[0] + " Test": "Name Test",
                    Address = args.Length > 0 ? args[0] + " Test": "Name Test",
                    Phone = args.Length > 0 ? args[0] + " Test": "Name Test",
                };

                context.Person.Add(std);
                context.SaveChanges();
            }
        }
    }
}