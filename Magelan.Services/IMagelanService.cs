using System.Collections.Generic;
using Magelan.Domains;

namespace Magelan.Services {
    public interface IMagelanService {
        void AddPost(Post newPost);
        List<Post> GetPosts();
    }
}