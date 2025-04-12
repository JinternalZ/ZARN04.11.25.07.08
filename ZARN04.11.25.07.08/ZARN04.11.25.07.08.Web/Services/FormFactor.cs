using ZARN04._11._25._07._08.Shared.Services;

namespace ZARN04._11._25._07._08.Web.Services;

public class FormFactor : IFormFactor
{
    public string GetFormFactor()
    {
        return "Web";
    }

    public string GetPlatform()
    {
        return Environment.OSVersion.ToString();
    }
}
