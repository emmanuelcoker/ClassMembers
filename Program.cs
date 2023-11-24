using ClassMembers.Models;

namespace ClassMembers
{
    public class Program
    {
        static void Main(string[] args)
        {

            Product newProduct = new Product("Shoe", "A size 42 shoe", 32000.99, Product.Brand.Addidas);
            newProduct.ShowProductDetails();



            Console.WriteLine();
            Console.WriteLine("---- Record -----");
            //Implementing Record
            Student newStudent = new Student("Ben", "Franklin", 20);
            Console.WriteLine($"Student First Name: {newStudent.FirstName}");
            Console.WriteLine($"Student Last Name: {newStudent.LastName}");
            Console.WriteLine($"Student Age: {newStudent.Age}");

        }
    }

    public record Student(string? FirstName, string? LastName, int? Age);

}