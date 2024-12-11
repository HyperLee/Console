namespace TempCode
{
    public enum NewEnum
    {
        
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="bloomDay"></param>
    /// <param name="days"></param>
    /// <param name="m"></param>
    /// <param name="k"></param>
    /// <returns></returns> <summary>
    public bool CanMake(int[] bloomDay, int days, int m, int k) 
    {
        int bouquets = 0;
        int flowers = 0;
        int length = bloomDay.Length;
        for(int i = 0; i < length, bouquets < m; i++)
        {
            if(bloomDay[i] < days)
            {
                flowers++;
                if(flowers == k)
                {
                    bouquets++;
                    flowers = 0;
                }
            }
            else
            {
                flowers = 0
            }
        }

        return bouquets == m;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="bloomDay"></param>
    /// <param name="m"></param>
    /// <param name="k"></param>
    /// <returns></returns> <summary>
    public int MinDays(int[] bloomDay, int m, int k) 
	{
        if((long) m * k > bloomDay.Length)
        {
            return -1;
        }

        int low = int.MaxValue, high = 0;
        int length = bloomDay.Length;
        for(int i = 0; i < length; i++)
        {
            low = Math.Min(low, bloomDay[i]);
            high = Math.Max(high, bloomDay[i]);
        }

        while(low < high)
        {
            int days = (high - low) / 2 + low;
            if(CanMake(bloomDay, days, low, high))
            {
                high = days;
            }
            else
            {
                low = days +1;
            }
        }
        return low;
    }

}