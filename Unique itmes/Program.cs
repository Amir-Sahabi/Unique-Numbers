namespace Unique_itmes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" (Split numbers with Space) \n \n Enter the Numbers : ");
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int uniquecount = GetNumberOfUniqueElements(array);
            Console.WriteLine("\n Number of Unique Items :  " + uniquecount);
            
            static int GetNumberOfUniqueElements(int[] array)
            {
                
                HashSet<int> uniqueElements = new HashSet<int>();
                
                foreach (int element in array)
                {
                    
                    uniqueElements.Add(element);
                }
                // Return the number of unique elements in the set.
                return uniqueElements.Count;
            }




        }
    }
}