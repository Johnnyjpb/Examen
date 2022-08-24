using LinqTest.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTest.Controller
{
    public static class MainController
    {
        #region Sending list of numbers
        /// <summary>
        ///     Making a function whom will return ascend list
        /// </summary>
        /// <returns> List<int> </returns>
        public static List<int> getAscNumberList()
        {
            List<int> numberList = new List<int>();
            for (int i = 1; i <= 100; i++)
            {
                numberList.Add(i);
            }
            return numberList;
        }

        /// <summary>
        ///     Making a function whom will return descend list
        /// </summary>
        /// <returns> List<int> </returns>
        public static List<int> getDescNumberList()
        {
            List<int> numberList = new List<int>();
            for (int i = 100; i > 0; i--)
            {
                numberList.Add(i);
            }
            return numberList;
        }
        #endregion

        #region Making list whom will return cousins numbers in at ascend way
        /// <summary>
        ///     this method will return cousins number in ascending
        /// </summary>
        /// <param name="listDesc"></param>
        /// <returns> List<int> </returns>
        public static List<int> getCousinsNumbersAsc(List<int> listDesc)
        {
            List<int> listAsc = listDesc.OrderBy((number) => number).ToList();
            List<int> listToReturn = listAsc.Where((number) =>
            {
                int count = 0;
                for (int i = 1; i < listAsc.Max(); i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count <= 2)
                {
                    return true;
                }
                return false;
            }).ToList();
            return listToReturn;
        }

        #endregion

        #region Sum method with params
        /// <summary>
        ///     Return a sum
        /// </summary>
        /// <param name="numberList"></param>
        /// <returns> int </returns>
        public static int sumList(List<int> numberList)
        {
            return numberList.Sum();
        }

        #endregion

        #region Return differents kind of list that filter another list
        /// <summary>
        ///     Here we are getting list that will return max values than a "N" number
        /// </summary>
        /// <param name="number"></param>
        /// <param name="listRequest"></param>
        /// <returns> List<int> </returns>
        public static List<int> getNumberUpThan(int number, List<int> listRequest)
        {
            return listRequest.Where((numberList) => numberList > number).ToList();
        }

        /// <summary>
        ///     Return in just a line the numbers who can be divided by 2
        /// </summary>
        /// <param name="listRequest"></param>
        /// <returns> List<int> </returns>
        public static List<int> getCoupleNumbers(List<int> listRequest)
        {
            return listRequest.Where((number) => number % 2 == 0).ToList();
        }

        /// <summary>
        ///     Return in just a line a no couple number
        /// </summary>
        /// <param name="listRequest"></param>
        /// <returns> List<int> </returns>
        public static List<int> getNoCoupleNumbers(List<int> listRequest)
        {
            return listRequest.Where((number) => number % 2 != 0).ToList();
        }

        /// <summary>
        ///     Return the repetition of times that find an element
        /// </summary>
        /// <param name="number"></param>
        /// <param name="listRequest"></param>
        /// <returns> int </returns>
        public static int getRepeatItValue(int number, List<int> listRequest)
        {
            return listRequest.Count((numberList) => numberList == number);
        }

        #endregion

        #region Create a list of object by repetition
        /// <summary>
        ///     Return a numberlist of numbers in a preview list.
        /// </summary>
        /// <param name="listRequest"></param>
        /// <returns> List<NumberList> </returns>
        public static List<NumberList> getInfoFromListOfRepetition(List<int> listRequest, int rep)
        {
            return listRequest.GroupBy((nu) => nu)
            .Where(x => x.Count() == rep)
            .Select((num) => new NumberList()
            {
                number = num.FirstOrDefault(),
                timesOf = num.Count()
            }).ToList();
        }

        /// <summary>
        ///     Return the sum from a list of objects
        /// </summary>
        /// <param name="listRequest"></param>
        /// <returns> int </returns>
        public static int sumListOfRepetition(List<NumberList> listRequest)
        {
            return listRequest.Sum((number) => number.number);
        }

        #endregion

    }
}
