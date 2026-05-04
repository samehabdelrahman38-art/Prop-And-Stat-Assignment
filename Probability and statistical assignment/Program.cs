using System.Reflection;



int[] nums = {115 , 182, 191,31,196 , 1099 , 5 , 172 , 10 , 179 , 83 , 21 ,20 ,21,  186 ,177 , 195 ,193 , 188 , 199 , 62 , 109 , 105 , 183  , 110 };
int sigma = 0 ; 

for (int i = 0   ; i < nums.Length;i++  ){sigma += nums[i];}

float Mean = (float)sigma/nums.Length;     

Console.WriteLine("Mean = " + Mean);

Array.Sort(nums);

Console.WriteLine("array after sorting : ");

foreach (int num in nums ){Console.Write( num + " ");}

float  median = 0 ; 

if (nums.Length % 2 == 0)
{
    median = (nums[nums.Length/2]+nums[nums.Length/2+1])/2;
}


else
{
    median = nums[nums.Length/2];
}

Console.WriteLine("median = " + median );

int Mode(int[] arr)
{
    int maxCount = 0;
    int mode = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        int count = 0;
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[j] == arr[i])
            {
                count++;
            }
        }

        if (count > maxCount)
        {
            maxCount = count;
            mode = arr[i];
        }
        else if (count == maxCount && arr[i] != mode)
        {
            mode = -1; 
        }
    }

    return mode;
}

Console.WriteLine("Mode = " + Mode(nums));


float firstQuartile = nums[(int)(nums.Length * 0.25)];
Console.WriteLine("firstQuartile = " + firstQuartile);
float secondQuartile = nums[(int)(nums.Length * 0.5)];
Console.WriteLine("secondQuartile = " + secondQuartile);
float thirdQuartile = nums[(int)(nums.Length * 0.75)];
Console.WriteLine("thirdQuartile = " + thirdQuartile);

float P20 = nums[(int)(nums.Length * 0.2f)];

Console.WriteLine("P20 = " + P20);

float P50 = nums[(int)(nums.Length * 0.5f)];

Console.WriteLine("P50 = " + P50);

int range = nums[nums.Length - 1] - nums[0];

Console.WriteLine("Range = " + range);

float interquartilerange = thirdQuartile - firstQuartile;
Console.WriteLine("Interquartile Range = " + interquartilerange);

float summationofdeviations = 0;

for (int i = 0; i < nums.Length; i++)
{
    summationofdeviations += nums[i] - Mean;
}
Console.WriteLine("Sum of deviations = " + (float)summationofdeviations);

float variance = 0;

for (int i = 0; i < nums.Length; i++)
{
    variance += (nums[i] - Mean) * (nums[i] - Mean) / nums.Length;
}

Console.WriteLine("Variance = " + variance);

float standarddeviation = (float)Math.Sqrt(variance);
Console.WriteLine("Standard Deviation = " + standarddeviation);

Console.WriteLine("Check if the input number is an outlier : ");

int N = Convert.ToInt32(Console.ReadLine());

float min = firstQuartile - 1.5f * interquartilerange;
float max = thirdQuartile + 1.5f * interquartilerange;

if (N < min || N > max)
{
        Console.WriteLine(N + " is an outlier.");
    
}
    
else
{
    Console.WriteLine(N + " is not an outlier.");
}
