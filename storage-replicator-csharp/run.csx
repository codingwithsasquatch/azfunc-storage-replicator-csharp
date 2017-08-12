public static void Run(Stream inputBlob, string name, out Stream outputBlob, TraceWriter log)
{
    log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {inputBlob.Length} Bytes");
    outputBlob = inputBlob;
}
