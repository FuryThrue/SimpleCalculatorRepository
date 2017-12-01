using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Number_5()
        {         
            var userString = "5";
         
            var parser = new Parser(userString);
            var result = parser.getFirstNumber();
       
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Number_minus5()
        {
            var userString = "-5";

            var parser = new Parser(userString);
            var result = parser.getFirstNumber();

            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Number_5Point5()
        {          
            var userString = "5.5";
          
            var parser = new Parser(userString);
            var result = parser.getFirstNumber();
         
            Assert.AreEqual(5.5, result);
        }

        [TestMethod]
        public void Number_5Comma5()
        {         
            var userString = "5,5";
         
            var parser = new Parser(userString);
            var result = parser.getFirstNumber();
        
            Assert.AreEqual(5.5, result);
        }

        [TestMethod]
        public void Number_minus5LeftBracket()
        {
            var userString = "-5)0";

            var parser = new Parser(userString);
            var result = parser.getFirstNumber();

            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Word()
        {       
            var userString = "word";
  
            var parser = new Parser(userString);
            var result = parser.getFirstNumber();
            
            Assert.AreEqual(double.NaN, result);
        }

        [TestMethod]
        public void Operation_Plus()
        {         
            var userString = "5+";
     
            var parser = new Parser(userString);
            var result = parser.getOperation();
   
            Assert.AreEqual('+', result);
        }

        [TestMethod]
        public void Operation_Minus()
        {          
            var userString = "5-";
      
            var parser = new Parser(userString);
            var result = parser.getOperation();
   
            Assert.AreEqual('-', result);
        }

        [TestMethod]
        public void Operation_Multiply()
        {        
            var userString = "5*";
 
            var parser = new Parser(userString);
            var result = parser.getOperation();

            Assert.AreEqual('*', result);
        }

        [TestMethod]
        public void Operation_Divide()
        {
            var userString = "5/";
            
            var parser = new Parser(userString);
            var result = parser.getOperation();
            
            Assert.AreEqual('/', result);
        }

        [TestMethod]
        public void Operation_Unknown()
        {
            var userString = "5)";

            var parser = new Parser(userString);
            var result = parser.getOperation();

            Assert.AreEqual('\0', result);
        }
    }
}
