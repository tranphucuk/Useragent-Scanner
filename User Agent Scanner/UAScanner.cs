using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thanhps42.HttpClient;

namespace User_Agent_Scanner
{
    public partial class UAScanner
    {
        public event EventHandler<ItemCounteventArg> ItemCount;
        protected virtual void OnItemCount(ItemCounteventArg e)
        {
            ItemCount?.Invoke(this, e);
        }

        public event EventHandler<ItemAddedEventArg> ItemAdded;
        protected virtual void OnItemAdded(ItemAddedEventArg e)
        {
            ItemAdded?.Invoke(this, e);
        }
        Http _http = new Http();
        Random rand = new Random();
        public bool IsStopScan = false;
        public void ScanAndWriteToFile(ScanInfo info)
        {
            if (IsStopScan) return;
            List<UserAgent> list = new List<UserAgent>();
            for (int i = rand.Next(1, 10); true; i++)
            {
                if (IsStopScan) return;
                var link = string.Empty;
                link = $"https://developers.whatismybrowser.com/useragents/explore/{info.ExploreBy}/{info.Type}/{i}";

                var res = _http.Get(link);

                var documentNode = res.DocumentNode.SelectNodes("//td[@class='useragent']");
                if (info.DeviceName == null)
                {
                    foreach (var item in documentNode)
                    {
                        if (IsStopScan) return;
                        UserAgent userAgent = new UserAgent();
                        userAgent.UA = item.InnerText;
                        list.Add(userAgent);

                        OnItemAdded(new ItemAddedEventArg()
                        {
                            Item = userAgent,
                        });
                        OnItemCount(new ItemCounteventArg()
                        {
                            ItemCount = list.Count,
                        });
                    }
                }
                else
                {
                    foreach (var item in documentNode)
                    {
                        if (IsStopScan) return;
                        UserAgent userAgent = new UserAgent();
                        var itemTolower = item.InnerText.ToLower();
                        if (itemTolower.Contains(info.DeviceName.ToLower()) && itemTolower.Contains(info.OSVersion.ToLower()) && !itemTolower.Contains("ipod") && !itemTolower.Contains("ipad") && !itemTolower.Contains("ipod touch"))
                        {
                            userAgent.UA = item.InnerText;
                            list.Add(userAgent);

                            OnItemAdded(new ItemAddedEventArg()
                            {
                                Item = userAgent,
                            });
                            OnItemCount(new ItemCounteventArg()
                            {
                                ItemCount = list.Count,
                            });
                        }
                        if (itemTolower.Contains(info.DeviceName.ToLower()) && itemTolower.Contains(info.OSVersion.ToLower()) && !itemTolower.Contains("iphone") && !itemTolower.Contains("ipod") && !itemTolower.Contains("ipod touch"))
                        {
                            userAgent.UA = item.InnerText;
                            list.Add(userAgent);

                            OnItemAdded(new ItemAddedEventArg()
                            {
                                Item = userAgent,
                            });
                            OnItemCount(new ItemCounteventArg()
                            {
                                ItemCount = list.Count,
                            });
                        }
                        if (itemTolower.Contains(info.DeviceName.ToLower()) && itemTolower.Contains(info.OSVersion.ToLower()))
                        {
                            userAgent.UA = item.InnerText;
                            list.Add(userAgent);

                            OnItemAdded(new ItemAddedEventArg()
                            {
                                Item = userAgent,
                            });
                            OnItemCount(new ItemCounteventArg()
                            {
                                ItemCount = list.Count,
                            });
                        }
                    }
                }
            }
        }
    }
}
