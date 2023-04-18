
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            int agentType = 0;
            float age = 25;
            float experience = 3;
            int productType = 0;

            int expected = -1;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_NonExistentAge()
        {
            int agentType = 0;
            float age = 0;
            float experience = 3;
            int productType = 1;

            int expected = -1;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetQuantityForProduct_Age26Exp4Product1()
        {
            int agentType = 0;
            float age = 26;
            float experience = 4;
            int productType = 1;

            int expected = 7;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age26Exp2Product1()
        {
            int agentType = 0;
            float age = 26;
            float experience = 3;
            int productType = 1;

            int expected = 5;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age25Exp4Product1()
        {
            int agentType = 0;
            float age = 25;
            float experience = 4;
            int productType = 1;

            int expected = -1;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void GetQuantityForProduct_Age26Exp21Product1()
        {
            int agentType = 0;
            float age = 26;
            float experience = 21;
            int productType = 1;

            int expected = 42;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age26Exp41Product1()
        {
            int agentType = 0;
            float age = 26;
            float experience = 41;
            int productType = 1;

            int expected = 82;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age26Exp11Product1()
        {
            int agentType = 0;
            float age = 26;
            float experience = 11;
            int productType = 1;

            int expected = 22;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void GetQuantityForProduct_Age26Exp21Product2()
        {
            int agentType = 0;
            float age = 26;
            float experience = 21;
            int productType = 2;

            int expected = 84;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age26Exp41Product2()
        {
            int agentType = 0;
            float age = 26;
            float experience = 41;
            int productType = 2;

            int expected = 164;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age26Exp11Product2()
        {
            int agentType = 0;
            float age = 26;
            float experience = 11;
            int productType = 2;

            int expected = 44;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age23Exp1_5Product2()
        {
            int agentType = 0;
            float age = 23;
            float experience = 1.5f;
            int productType = 2;

            int expected = 5;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }


        [Fact]
        public void GetQuantityForProduct_Age26Exp21Product3()
        {
            int agentType = 0;
            float age = 26;
            float experience = 21;
            int productType = 3;

            int expected = 105;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age26Exp41Product3()
        {
            int agentType = 0;
            float age = 26;
            float experience = 41;
            int productType = 3;

            int expected = 205;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age26Exp11Product3()
        {
            int agentType = 0;
            float age = 26;
            float experience = 11;
            int productType = 3;

            int expected = 55;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetQuantityForProduct_Age26Exp4Product2()
        {
            int agentType = 0;
            float age = 26;
            float experience = 4;
            int productType = 2;

            int expected = 13;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age26Exp2Product2()
        {
            int agentType = 0;
            float age = 26;
            float experience = 3;
            int productType = 2;

            int expected = 10;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age25Exp4Product2()
        {
            int agentType = 0;
            float age = 25;
            float experience = 4;
            int productType = 2;

            int expected = -1;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetQuantityForProduct_Age26Exp4Product3()
        {
            int agentType = 0;
            float age = 26;
            float experience = 4;
            int productType = 3;

            int expected = 16;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age26Exp2Product3()
        {
            int agentType = 0;
            float age = 26;
            float experience = 3;
            int productType = 3;

            int expected = 12;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age25Exp2Product3()
        {
            int agentType = 0;
            float age = 25;
            float experience = 2;
            int productType = 3;

            int expected = 8;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age25Exp2Product2()
        {
            int agentType = 0;
            float age = 25;
            float experience = 2;
            int productType = 2;

            int expected = 6;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age25Exp2Product1()
        {
            int agentType = 0;
            float age = 25;
            float experience = 2;
            int productType = 1;

            int expected = 4;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_Age25Exp4Product3()
        {
            int agentType = 0;
            float age = 25;
            float experience = 4;
            int productType = 3;

            int expected = -1;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_AgeNegavive()
        {
            int agentType = 0;
            float age = -1;
            float experience = 5;
            int productType = 3;

            int expected = -1;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_ProductTypeNegavive()
        {
            int agentType = 0;
            float age = 25;
            float experience = 5;
            int productType = -1;

            int expected = -1;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
        [Fact]
        public void GetQuantityForProduct_ExperienceNegavive()
        {
            int agentType = 0;
            float age = 25;
            float experience = -1;
            int productType = 3;

            int expected = -1;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetQuantityForProduct_NonExistentExperience()
        {
            int agentType = 0;
            float age = 25;
            float experience = -1;
            int productType = 1;

            int expected = -1;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetQuantityForProduct_NonExistentProductType1()
        {
            int agentType = 0;
            float age = 26;
            float experience = 12;
            int productType = 1;

            int expected = 24;

            WSUniversalLib.dll.Calculation c = new WSUniversalLib.dll.Calculation();
            int result = c.GetPriorityForAgent(agentType, age, experience, productType);

            Assert.Equal(expected, result);
        }
    }
}