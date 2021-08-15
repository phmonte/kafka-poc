using System;
using System.Text.Json;
using Confluent.Kafka;

namespace App.Consumer
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConsumerConfig
            {
                GroupId = $"dbserver1.dbo.Person.{Guid.NewGuid():N}.group.id",
                BootstrapServers = "192.168.0.73:9092"
            };
            
            using (var c = new ConsumerBuilder<string, string>(config).Build())
            {
                c.Subscribe("dbserver1.dbo.Person");
                try
                {
                    while (true)
                    {
                        try
                        {
                            var cr = c.Consume();
                            Result.Mensagem b = null;

                            var options = new JsonSerializerOptions
                            {
                                PropertyNameCaseInsensitive = true
                            };
                            
                            if (cr.Message.Value != null)
                                b = JsonSerializer.Deserialize<Result.Mensagem>(cr.Message?.Value, options);

                            var chave = JsonSerializer.Deserialize<Result.KeyIndentification>(cr.Key);

                            if (b == null)
                            {
                                Console.WriteLine($"DELETADO - {chave.Payload.Id}");
                            }
                            else
                            {
                                Console.WriteLine($"ID:{b.Payload?.After.Id}\nNOME:{b.Payload?.After.Name}\nENDERECO:{b.Payload?.After.Address}\nTELEFONE:{b.Payload?.After.Phone}");
                            }

                            Console.WriteLine("======================================================== \n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw e;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}