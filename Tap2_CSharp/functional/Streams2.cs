using System;
using System.Collections.Generic;
using System.Text;


namespace functional
{
    class Streams2
    {

        public static void main(String[] args)
        {
            LinkedList<Animal> people = new LinkedList<Animal>();
            Animal a1 = new Animal("loro", 24);
            Animal a2 = new Animal("oso", 75);
            Animal a3 = new Animal("gato", 16);
            Animal a4 = new Animal("perro", 6);
            Animal a5 = new Animal("elefante", 67);
            Animal a6 = new Animal("mamut", 81);
            
            people.AddLast(a1);
            people.AddLast(a2);
            people.AddLast(a3);
            people.AddLast(a4);
            people.AddLast(a5);
            people.AddLast(a6);



            List<String> list = people.stream().map(Animal: Animal:, :, getName).collect(Collectors.toList());
            Set<String> set = people.stream().map(Animal: Animal:, :, getName).collect(Collectors.toCollection(java.util.TreeSet, :, :, new));
            set.forEach(System.out, :, :, println);
            
            
            
            String joined = people.stream().map(Object: Object:, :, toString).collect(Collectors.joining(", "));
            System.out.println(joined);
            int total = people.stream().collect(Collectors.summingInt(Animal: Animal:, :, getAge));
            
            
            
            
            System.out.println(("cnt:" + total));
            List<Animal> ordered;
            x.getName().compareTo(y.getName());
            collect(Collectors.toList());
            
            
            System.out.println(("sorted:" + ordered));
            
            
            List<Person> persons = Person.createShortList();
            
            Map<Gender, List<Person>> byGender = persons.stream().collect(Collectors.groupingBy(Person: Person:, :, getGender));
            byGender.get(Gender.FEMALE).forEach(System.out, :, :, println);
            
            
            
            Map<Gender, Integer> totalAge = persons.stream().collect(Collectors.groupingBy(Person: Person:, :, getGender, Collectors.summingInt(Person: Person:, :, getAge)));
            
            
            System.out.println(("age summation of olf males:" + totalAge.get(Gender.MALE)));
            
            
            Map<Boolean, List<Animal>> oldAnimals = people.stream().collect(Collectors.partitioningBy(s, -, Greater, (s.getAge() >= 30)));
            
            System.out.println("old ones:");
            
            oldAnimals.get(true).forEach(System.out, :, :, println);
            
            System.out.println("young ones:");
            
            
            oldAnimals.get(false).forEach(System.out, :, :, println);
        }

    }
}
