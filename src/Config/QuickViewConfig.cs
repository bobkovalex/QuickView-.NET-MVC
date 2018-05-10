using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Web;

namespace QuickView.Config
{
    public class QuickViewConfig
    {
        private Application application;

        private Resources resources;

        private Server server;

        private NameValueCollection quickViewConfig = (NameValueCollection)System.Configuration.ConfigurationManager.GetSection("quickViewConfig");

        public QuickViewConfig()
        {
            application = new Application();
            resources = new Resources();
            server = new Server();
        }

        public Application getApplication()
        {
            return application;
        }

        public Resources getResources()
        {
            return resources;
        }

        public Server getServer()
        {
            return server;
        }

        /**
         * Application related configurations
         */
        public class Application
        {
            private String filesDirectory;

            private String licensePath;

            private String fontsDirectory;

            public String getFilesDirectory()
            {
                filesDirectory = new QuickViewConfig().quickViewConfig["filesDirectory"];
                return filesDirectory;
            }

            public void setFilesDirectory(String filesDirectory)
            {
                this.filesDirectory = filesDirectory;
            }

            public String getLicensePath()
            {
                licensePath = new QuickViewConfig().quickViewConfig["licensePath"];
                return licensePath;
            }

            public void setLicensePath(String licensePath)
            {
                this.licensePath = licensePath;
            }

            public String getFontsDirectory()
            {
                fontsDirectory = new QuickViewConfig().quickViewConfig["fontsDirectory"];
                return fontsDirectory;
            }

            public void setFontsDirectory(String fontsDirectory)
            {
                this.fontsDirectory = fontsDirectory;
            }
        }

        /**
         * Resources related configuration
         */
        public class Resources
        {
            private bool runAsService;

            private String resourcesUrl;

            private int preloadPageCount;

            private bool zoom;

            private bool pageSelector;

            private bool search;

            private bool thumbnails;

            private bool rotate;

            private bool download;

            private bool upload;

            private bool print;

            private String defaultDocument;

            private bool browse;

            private bool htmlMode;

            private bool rewrite;

            private bool offlineMode;

            public bool getRunAsService()
            {
                runAsService = bool.Parse(new QuickViewConfig().quickViewConfig["runAsService"]);
                return runAsService;
            }

            public void setRunAsService(bool runAsService)
            {
                this.runAsService = runAsService;
            }

            public String getResourcesUrl()
            {
                resourcesUrl = new QuickViewConfig().quickViewConfig["resourcesUrl"];
                return resourcesUrl;
            }

            public void setResourcesUrl(String resourcesUrl)
            {
                this.resourcesUrl = resourcesUrl;
            }

            public int getPreloadPageCount()
            {
                preloadPageCount = Convert.ToInt32(new QuickViewConfig().quickViewConfig["preloadPageCount"]);
                return preloadPageCount;
            }

            public void setPreloadPageCount(int preloadPageCount)
            {
                this.preloadPageCount = preloadPageCount;
            }

            public bool isZoom()
            {
                zoom = bool.Parse(new QuickViewConfig().quickViewConfig["zoom"]);
                return zoom;
            }

            public void setZoom(bool zoom)
            {
                this.zoom = zoom;
            }

            public bool isPageSelector()
            {
                pageSelector = bool.Parse(new QuickViewConfig().quickViewConfig["pageSelector"]);
                return pageSelector;
            }

            public void setPageSelector(bool pageSelector)
            {
                this.pageSelector = pageSelector;
            }

            public bool isSearch()
            {
                search = bool.Parse(new QuickViewConfig().quickViewConfig["search"]);
                return search;
            }

            public void setSearch(bool search)
            {
                this.search = search;
            }

            public bool isThumbnails()
            {
                thumbnails = bool.Parse(new QuickViewConfig().quickViewConfig["thumbnails"]);
                return thumbnails;
            }

            public void setThumbnails(bool thumbnails)
            {
                this.thumbnails = thumbnails;
            }

            public bool isRotate()
            {
                rotate = bool.Parse(new QuickViewConfig().quickViewConfig["rotate"]);
                return rotate;
            }

            public void setRotate(bool rotate)
            {
                this.rotate = rotate;
            }

            public bool isDownload()
            {
                download = bool.Parse(new QuickViewConfig().quickViewConfig["download"]);
                return download;
            }

            public void setDownload(bool download)
            {
                this.download = download;
            }

            public bool isUpload()
            {
                upload = bool.Parse(new QuickViewConfig().quickViewConfig["upload"]);
                return upload;
            }

            public void setUpload(bool upload)
            {
                this.upload = upload;
            }

            public bool isPrint()
            {
                print = bool.Parse(new QuickViewConfig().quickViewConfig["print"]);
                return print;
            }

            public void setPrint(bool print)
            {
                this.print = print;
            }

            public String getDefaultDocument()
            {
                defaultDocument = new QuickViewConfig().quickViewConfig["defaultDocument"];
                return defaultDocument;
            }

            public void setDefaultDocument(String defaultDocument)
            {
                this.defaultDocument = defaultDocument;
            }

            public bool isBrowse()
            {
                browse = bool.Parse(new QuickViewConfig().quickViewConfig["browse"]);
                return browse;
            }

            public void setBrowse(bool browse)
            {
                this.browse = browse;
            }

            public bool isHtmlMode()
            {
                htmlMode = bool.Parse(new QuickViewConfig().quickViewConfig["htmlMode"]);
                return htmlMode;
            }

            public void setHtmlMode(bool htmlMode)
            {
                this.htmlMode = htmlMode;
            }

            public bool isRewrite()
            {
                rewrite = bool.Parse(new QuickViewConfig().quickViewConfig["rewrite"]);
                return rewrite;
            }

            public void setRewrite(bool rewrite)
            {
                this.rewrite = rewrite;
            }

            public bool isOfflineMode()
            {
                offlineMode = bool.Parse(new QuickViewConfig().quickViewConfig["offlineMode"]);
                return offlineMode;
            }

            public void setOfflineMode(bool offlineMode) { this.offlineMode = offlineMode; }
        }

        /**
         * Server related configurations
         */
        public class Server
        {
            private int httpPort;
            private String hostAddress;

            public int getHttpPort()
            {
                httpPort = HttpContext.Current.Request.Url.Port;
                return httpPort;
            }

            public void setHttpPort(int httpPort)
            {
                this.httpPort = httpPort;
            }

            public String getHostAddress()
            {
                hostAddress = HttpContext.Current.Request.Url.Host;
                return hostAddress;
            }

            public void setHostAddress(String hostAddress)
            {
                this.hostAddress = hostAddress;
            }
        }

    }
}