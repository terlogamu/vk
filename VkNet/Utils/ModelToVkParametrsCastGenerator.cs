﻿// Autogenerated at 24.03.2016 23:26:44
// DO NOT EDIT THIS FILE CAUSE ALL CHANGES WILL BE DELETED AUTOMATICALLY

using VkNet.Model.RequestParams;

namespace VkNet.Utils
{
    using System.Collections.Generic;

    partial class VkParameters : Dictionary<string, string>
    {
		public static implicit operator VkParameters(AccountRegisterDeviceParams p)
		{
            return AccountRegisterDeviceParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(AccountSaveProfileInfoParams p)
		{
            return AccountSaveProfileInfoParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(AppGetCatalogParams p)
		{
            return AppGetCatalogParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(AppGetParams p)
		{
            return AppGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(AppSendRequestParams p)
		{
            return AppSendRequestParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(AudioEditParams p)
		{
            return AudioEditParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(AudioGetParams p)
		{
            return AudioGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(AudioSearchParams p)
		{
            return AudioSearchParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(AuthConfirmParams p)
		{
            return AuthConfirmParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(AuthSignupParams p)
		{
            return AuthSignupParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(FriendsGetMutualParams p)
		{
            return FriendsGetMutualParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(FriendsGetOnlineParams p)
		{
            return FriendsGetOnlineParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(FriendsGetParams p)
		{
            return FriendsGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(FriendsGetRequestsParams p)
		{
            return FriendsGetRequestsParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(FriendsSearchParams p)
		{
            return FriendsSearchParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(GroupsBanUserParams p)
		{
            return GroupsBanUserParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(GroupsEditManagerParams p)
		{
            return GroupsEditManagerParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(GroupsEditParams p)
		{
            return GroupsEditParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(GroupsGetMembersParams p)
		{
            return GroupsGetMembersParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(GroupsGetParams p)
		{
            return GroupsGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(GroupsSearchParams p)
		{
            return GroupsSearchParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(LikesAddParams p)
		{
            return LikesAddParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(LikesGetListParams p)
		{
            return LikesGetListParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MarketCreateCommentParams p)
		{
            return MarketCreateCommentParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MarketGetCommentsParams p)
		{
            return MarketGetCommentsParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MarketProductParams p)
		{
            return MarketProductParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MarketSearchParams p)
		{
            return MarketSearchParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MessagesDialogsGetParams p)
		{
            return MessagesDialogsGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MessagesGetHistoryAttachmentsParams p)
		{
            return MessagesGetHistoryAttachmentsParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MessagesGetHistoryParams p)
		{
            return MessagesGetHistoryParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MessagesGetLongPollHistoryParams p)
		{
            return MessagesGetLongPollHistoryParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MessagesGetParams p)
		{
            return MessagesGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MessagesSendParams p)
		{
            return MessagesSendParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(MessagesSendStickerParams p)
		{
            return MessagesSendStickerParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(NewsFeedGetCommentsParams p)
		{
            return NewsFeedGetCommentsParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(NewsFeedGetParams p)
		{
            return NewsFeedGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(NewsFeedGetRecommendedParams p)
		{
            return NewsFeedGetRecommendedParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(NewsFeedSearchParams p)
		{
            return NewsFeedSearchParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PagesGetParams p)
		{
            return PagesGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoCreateAlbumParams p)
		{
            return PhotoCreateAlbumParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoCreateCommentParams p)
		{
            return PhotoCreateCommentParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoEditAlbumParams p)
		{
            return PhotoEditAlbumParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoEditParams p)
		{
            return PhotoEditParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoGetAlbumsParams p)
		{
            return PhotoGetAlbumsParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoGetAllCommentsParams p)
		{
            return PhotoGetAllCommentsParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoGetAllParams p)
		{
            return PhotoGetAllParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoGetCommentsParams p)
		{
            return PhotoGetCommentsParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoGetParams p)
		{
            return PhotoGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoGetUserPhotosParams p)
		{
            return PhotoGetUserPhotosParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoPutTagParams p)
		{
            return PhotoPutTagParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoSaveParams p)
		{
            return PhotoSaveParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(PhotoSearchParams p)
		{
            return PhotoSearchParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(UserSearchParams p)
		{
            return UserSearchParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(UsersGetNearbyParams p)
		{
            return UsersGetNearbyParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(VideoCreateCommentParams p)
		{
            return VideoCreateCommentParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(VideoEditParams p)
		{
            return VideoEditParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(VideoGetCommentsParams p)
		{
            return VideoGetCommentsParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(VideoGetParams p)
		{
            return VideoGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(VideoReorderVideosParams p)
		{
            return VideoReorderVideosParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(VideoSaveParams p)
		{
            return VideoSaveParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(VideoSearchParams p)
		{
            return VideoSearchParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(WallAddCommentParams p)
		{
            return WallAddCommentParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(WallEditParams p)
		{
            return WallEditParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(WallGetCommentsParams p)
		{
            return WallGetCommentsParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(WallGetParams p)
		{
            return WallGetParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(WallPostParams p)
		{
            return WallPostParams.ToVkParameters(p);
        }

		public static implicit operator VkParameters(WallSearchParams p)
		{
            return WallSearchParams.ToVkParameters(p);
        }


	}
}