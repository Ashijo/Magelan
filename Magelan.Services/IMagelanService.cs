using System.Collections.Generic;
using Magelan.Domains;
using Magelan.Repositories;

namespace Magelan.Services {
    public interface IMagelanService {
        void AddPost(Posts newPost);
        
        List<Posts> GetPosts();
    }
}