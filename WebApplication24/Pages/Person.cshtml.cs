using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication24.Models;

namespace WebApplication24.Pages
{
    public class PersonModel : PageModel
    {
        List<Person> people;
        public List<Person> DisplayedPeople { get; set; }
        public PersonModel()
        {
            people = new List<Person>()
            {
                new Person{Id=0, Name="Tom", Age=23},
                new Person {Id=1,Name = "Sam", Age=25},
                new Person {Id=2,Name="Bob", Age=23},
                new Person{Id=3,Name="Tom", Age=25}
            };
        }
        public void OnGet()
        {
            DisplayedPeople = people;
        }
        public void OnGetByName(string name)
        {
            DisplayedPeople = people.Where(p => p.Name.Contains(name)).ToList();
        }
        public void OnGetByAge(int age)
        {
            DisplayedPeople = people.Where(p => p.Age == age).ToList();
        }
        public void OnGetDeleteById(int id)
        {
            people.Remove(people.FirstOrDefault(x => x.Id == id));
            DisplayedPeople = people.ToList();
        }
        public void OnPostGreaterThan(int age)
        {
            DisplayedPeople = people.Where(p => p.Age > age).ToList();
        }
        public void OnPostLessThan(int age)
        {
            DisplayedPeople = people.Where(p => p.Age < age).ToList();
        }


    }
}
