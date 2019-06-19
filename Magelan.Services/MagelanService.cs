using System.Collections.Generic;
using Magelan.Domains;
using Magelan.Repositories.Interfaces;

namespace Magelan.Services {
    public class MagelanService : IMagelanService {
        private readonly IPostRepository _PostRepository;

        public MagelanService(IPostRepository postRepository) {
            _PostRepository = postRepository;
        }

        public void AddPost(Post newPost) {
            _PostRepository.Add(newPost);
            _PostRepository.SaveChanges();
        }

        public List<Post> GetPosts() {
            return _PostRepository.GetAll() as List<Post>;
        }
    }
}