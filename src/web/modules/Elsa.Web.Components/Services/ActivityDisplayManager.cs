using System.Collections.Generic;
using Elsa.Web.Services;
using Microsoft.Extensions.Logging;
using OrchardCore.DisplayManagement;
using OrchardCore.DisplayManagement.Descriptors;
using OrchardCore.DisplayManagement.Handlers;
using OrchardCore.DisplayManagement.Layout;
using OrchardCore.DisplayManagement.Theming;

namespace Elsa.Web.Components.Services
{
    public class ActivityDisplayManager : DisplayManager<IActivity>, IActivityDisplayManager
    {
        public ActivityDisplayManager(
            IEnumerable<IDisplayDriver<IActivity>> drivers, 
            IShapeTableManager shapeTableManager, 
            IShapeFactory shapeFactory, 
            IThemeManager themeManager, 
            ILogger<DisplayManager<IActivity>> logger, 
            ILayoutAccessor layoutAccessor) : base(drivers, shapeTableManager, shapeFactory, themeManager, logger, layoutAccessor)
        {
        }
    }
}