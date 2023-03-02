namespace SpeedTestLogger.Models;

public record TestResult(
    Guid SessionId,
    string User,
    int Device,
    long Timestamp,
    TestData Data);

public record TestData(
    TestSpeeds Speeds,
    TestClient Client,
    TestServer Server);

public record TestSpeeds(
    double Download,
    double Upload);

public record TestClient(
    string Ip,
    double Latitude,
    double Longitude,
    string Isp,
    string Country);

public record TestServer(
    string Host,
    double Latitude,
    double Longitude,
    string Country,
    double Distance,
    int Ping,
    int Id);