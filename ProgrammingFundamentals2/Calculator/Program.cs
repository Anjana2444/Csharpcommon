using Calculator;
Console.WriteLine("calculator");

operations ao1 = new operations(2,3);

int answer1 = ao1.Sum();
int answer2 = ao1.product();
int answer3 = ao1.difference();

Console.WriteLine($"Result of the Arithmetic operations : sum = {answer1} product = {answer2}, difference = {answer3}");

operations ao2 = new operations(2, 6);

answer1 = ao2.Sum();
answer2 = ao2.product();
answer3 = ao2.difference();

Console.WriteLine($"Result of the Arithmetic operations : sum = {answer1} product = {answer2}, difference = {answer3}");

Console.Read();