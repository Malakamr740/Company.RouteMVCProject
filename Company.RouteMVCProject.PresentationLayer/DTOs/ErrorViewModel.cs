namespace Company.RouteMVCProject.PresentationLayer.DTOs
{
    public class ErrorViewModel
    {
      
            public string? RequestId { get; set; }

            public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        
    }
}
