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
