using System;

class Program
{
	static void Main()
	{
        var result = Result<int>.Success(42);
        if (result.IsSuccess)
            Console.WriteLine(result.Value);

        var fail = Result<int>.Failure("Something went wrong");
        if (!fail.IsSuccess)
            Console.WriteLine(fail.Error.Message);
    }
}
