using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class FizzBuzzTests
    {
        private FizzBuzz _fizzBuzz;
        
        /// <summary>
        /// Initialization for tests
        /// </summary>
        [SetUp]
        public void Setup()
        {
            GameObject gameGameObject = 
                Object.Instantiate(Resources.Load<GameObject>("Prefabs/FizzBuzz"));
            _fizzBuzz = gameGameObject.GetComponent<FizzBuzz>();
        }
        
        /// <summary>
        /// Cleaning after test execution
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            Object.Destroy(_fizzBuzz.gameObject);
        }
        
        ///<summary>Checks that _fizzBuzz is not null</summary>
        [Test]
        public void FizzBuzzIsNotNull()
        {
            UnityEngine.Assertions.Assert.IsNotNull(_fizzBuzz);
        }

        /// <summary>
        /// Checks correct divisibility by 3
        /// </summary>
        [Test]
        public void FizzBuzzDivisibilityBy3Test()
        {
            Assert.IsTrue(FizzBuzz.IsDivisible(99, 3));
        }
        
        /// <summary>
        /// Checks correct divisibility by 5
        /// </summary>
        [Test]
        public void FizzBuzzDivisibilityBy5Test()
        {
            Assert.IsTrue(FizzBuzz.IsDivisible(60, 5));
        }
        
        /// <summary>
        /// Checks FizzBuzz result for non divisible by 3 or 5
        /// </summary>
        [Test]
        public void FizzBuzzNonDivisibleBy3And5Test()
        {
            Assert.AreEqual(_fizzBuzz.GetFizzBuzz(7, 7), "7");
        }
        
        /// <summary>
        /// Checks FizzBuzz result for a number divisible by 3 and 5
        /// </summary>
        [Test]
        public void FizzBuzzResultForDivisibleBy3And5Test()
        {
            Assert.AreEqual(_fizzBuzz.GetFizzBuzz(15, 15), "FizzBuzz");
        }
    }
}
