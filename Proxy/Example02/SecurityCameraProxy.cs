namespace Proxy.Example02
{
    public class SecurityCameraProxy : ISecurityCamera
    {
        private SecurityCamera _securityCamera;
        private bool _hasAccess;
        public SecurityCameraProxy(string cameraLocation, bool hasAccess)
        {
            _securityCamera = new SecurityCamera(cameraLocation);
            _hasAccess = hasAccess;

        }
        public void DisplayLiveFeed()
        {
            if (!_hasAccess)
            {
                Console.WriteLine("Access denied. You do not have permission to view this camera");
                return;
            }
            _securityCamera.DisplayLiveFeed();
        }
    }
}
