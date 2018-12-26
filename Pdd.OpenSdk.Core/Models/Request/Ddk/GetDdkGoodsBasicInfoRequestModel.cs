using Newtonsoft.Json;
namespace Pdd.OpenSdk.Core.Models.Request.Ddk
{
    public partial class GetDdkGoodsBasicInfoRequestModel : PddRequestModel
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonProperty("goods_id_list")]
        public string GoodsIdList { get; set; }

    }

}
