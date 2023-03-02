using SpeedTestLogger;
using SpeedTestLogger.Models;

Console.WriteLine("Hello SpeedTestLogger!");

var config = new LoggerConfiguration();
var runner = new SpeedTestRunner(config.LoggerLocation);
var testData = runner.RunSpeedTest();
var results = new TestResult(
    SessionId: Guid.NewGuid(),
    User: config.UserId,
    Device: config.LoggerId,
    Timestamp: DateTimeOffset.Now.ToUnixTimeMilliseconds(),
    Data: testData);

using var client = new SpeedTestApiClient(config.ApiUrl);

var success = await client.PublishTestResult(results);

if (success)
{
    Console.WriteLine("Speedtest complete!");
}
else
{
    Console.WriteLine("Speedtest failed!");
}