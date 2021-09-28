using System;
using System.Collections.Generic;
using System.Text;



namespace GenericKovVarKontrVar
{
    // Ковариантность обобщений (делегатов)
    class Animal { }
    class Cat : Animal { }
    class GenericDelegateKovar
    {
        delegate T MyDelegate<out T>();
        public static Cat CatCreator()
        {
            return new Cat();
        }
        public void start()
        {
            MyDelegate<Cat> delegateCat = new MyDelegate<Cat>(CatCreator);
            MyDelegate<Animal> delegateAnimal = delegateCat;
            Animal animal = delegateAnimal.Invoke();
            Console.WriteLine(delegateAnimal.GetType().Name);
        }
    }

    // Контрвариантность обобщений (делегатов)

    class GenericDelegateKontrvar
    {
        delegate void MyDelegateKontrvar<in T>(T a);
        public static void CatUser(Animal animal)
        {
            Console.WriteLine(animal.GetType().ToString());
        }
        public void start()
        {
            MyDelegateKontrvar<Animal> delegateAnimal = new MyDelegateKontrvar<Animal>(CatUser);
            MyDelegateKontrvar<Cat> delegateCat = delegateAnimal; // downcast от базового к производному

            delegateAnimal(new Animal());
            delegateCat(new Cat());
            Console.WriteLine(delegateAnimal.GetType().Name);

            
        }
    }

}
