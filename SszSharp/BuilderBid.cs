namespace SszSharp;

public class BuilderBid
{
    [SszElement(0, "Container")] public ExecutionPayloadHeader Header { get; set; }
    [SszElement(1, "uint64")] public ulong Value { get; set; }
    [SszElement(2, "Vector[uint8, 48]")] public byte[] Pubkey { get; set; }
}