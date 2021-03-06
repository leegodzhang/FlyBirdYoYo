using Newtonsoft.Json;
namespace Pdd.OpenSdk.Core.Models.Response.Goods
{
    public partial class UpdateGoodsInformationResponseModel : PddResponseModel
    {
        /// <summary>
        /// 返回response
        /// </summary>
        [JsonProperty("goods_update_response")]
        public GoodsUpdateResponseResponseModel GoodsUpdateResponse { get; set; }
        public partial class GoodsUpdateResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 提交申请的序列id
            /// </summary>
            [JsonProperty("goods_commit_id")]
            public int GoodsCommitId { get; set; }
            /// <summary>
            /// 是否修改成功
            /// </summary>
            [JsonProperty("is_success")]
            public object IsSuccess { get; set; }

        }

    }

}
