using Class_9.Dao;
using System;
using System.Linq;
using Class_9.Models;

namespace Class_9.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private readonly IRepository _repo;

    //private Nullable<int> myInt;
    //private int? myInt2;
    public MainService(IRepository repo)
    {
        _repo = repo;
    }

    public void Invoke()
    {
        var animals = _repo.Get();

        var searchedAnimal = _repo.Search("Rover");  //instead of hard coded Rover, use a user input or the file list
        Console.WriteLine(searchedAnimal.Name);

        //foreach (var animal in animals.OrderBy(a => a.Name))  //and OrderByDescending
        //{
        //    Console.WriteLine(animal?.Name);
        //}
        //Console.WriteLine("=================");

        //var filteredAnimals = animals.Where(a => FilterAnimals(a));
        //var filteredAnimals = animals.Where(FilterAnimals);
        //var filteredAnimals = animals.Where(a => a.Name == "Rover");  // a = animal

        //var animal = animals.FirstOrDefault(a => a.Name == "Rover");
        //Console.WriteLine(animal.Name);

        //var animal = animals.FirstOrDefault(a => a.Name == "Stripe");
        //Console.WriteLine(animal?.Name);  //if animal is null, do not execute-doesnt throw an error

        //var filteredAnimals = animals.Take(2);
        //foreach (var animal in filteredAnimals)
        //{
        //    Console.WriteLine(animal.Name);
        //}

        //var filteredAnimals = animals.Skip(2);
        //foreach (var animal in filteredAnimals)
        //{
        //    Console.WriteLine(animal.Name);
        //}

        //var pageSize = 3;
        //var page = 0;
        //for (int i = 0; i < animals.Count/pageSize; i++)
        //{
        //    var pagedAnimals = animals.Skip(page*pageSize).Take(pageSize);
        //    page++;
        //    foreach (var animal in pagedAnimals)
        //    {
        //        Console.WriteLine(animal?.Name);
        //    }
        //    Console.WriteLine("------------------");
        //}
        //Console.WriteLine("Next Section");

        //var filteredAnimals = animals.Take(2);
        //var filteredAnimals = animals.Skip(2);
        //foreach (var animal in filteredAnimals)
        //{
        //    Console.WriteLine(animal?.Name);
        //}
        
    }

    private bool FilterAnimals(Animal a)  //takes in an animal and returns a bool
    {
        return a.Name == "Rover";
    }
}
