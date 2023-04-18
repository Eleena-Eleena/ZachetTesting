using System.Reflection.Metadata.Ecma335;

namespace WSUniversalLib.dll
{


    public class Calculation
    {
        int priority;

        public int GetPriorityForAgent(int agentType, float age, float experience, int productType)
        {
            float agent = 0;

            if (productType == 1)
            {
                agent = 1.8f;
                if (experience > 10 && age > 25)
                {
                    agentType = (int)Math.Round(agent + 0.5f);
                }
                else if (experience > 20 && age > 25)
                {
                    agentType = (int)Math.Round(agent + 0.7f);
                }
                else if (experience > 40 && age > 25)
                {
                    agentType = (int)Math.Round(agent + 0.9f);
                }
                else if (experience <= 3 && age <= 25 && age >= 14 && experience >= 0)
                {
                    agentType = (int)Math.Round(agent + 0.1f);
                }
                else if (experience <= 10 && age > 25 && experience >= 0)
                {
                    return (int)Math.Round(agent * experience);
                }
                else
                {
                    return -1;
                }
            }
            else if (productType == 2)
            {
                agent = 3.2f;
                if (experience > 10 && age > 25)
                {
                    agentType = (int)Math.Round(agent + 0.5f);
                }
                else if (experience > 20 && age > 25)
                {
                    agentType = (int)Math.Round(agent + 0.7f);
                }
                else if (experience > 40 && age > 25)
                {
                    agentType = (int)Math.Round(agent + 0.9f);
                }
                else if (experience <= 3 && age <= 25 && age >= 14 && experience >= 0)
                {
                    agentType = (int)Math.Round(agent + 0.17f);
                }
                else if (experience <= 10 && age > 25 && experience >= 0)
                {
                    return (int)Math.Round(agent * experience + 0.1);
                }
                      else
                {
                    return -1;
                }
            }
           else if (productType == 3)
            {
                agent = 4.1f;
                if (experience > 10 && age > 25)
                {
                    agentType = (int)Math.Round(agent + 0.5f);
                }
                else if (experience > 20 && age > 25)
                {
                    agentType = (int)Math.Round(agent + 0.7f);
                }
                else if (experience > 40 && age > 25)
                {
                    agentType = (int)Math.Round(agent + 0.9f);
                }
                else if (experience <= 3 && age <= 25 && age >= 14 && experience >= 0)
                {
                    agentType = (int)Math.Round(agent + 0.26f);
                }
                else if(experience <= 10 && age > 25 && experience >= 0 )
                {
                    return (int)Math.Round(agent * experience + 0.1);
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
            priority = (int)Math.Round(agentType * experience + 0.1);
            return priority;
        }
    }
}

  
