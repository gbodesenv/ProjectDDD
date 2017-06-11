namespace Rj.SME.Sismonrio.Domain.Util.Helpers
{
    public class UrlUtil
    {
        public readonly UrlHelper UrlHelper;

        public UrlUtil(RequestContext requestContext)
        {
            UrlHelper = new UrlHelper(requestContext);
        }
    }
}
