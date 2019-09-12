using System.Collections.Generic;
using Magelan.Domains;
using Magelan.Repositories;
using Magelan.Repositories.Interfaces;

namespace Magelan.Services {
    public class MagelanService : IMagelanService {
        private readonly IPostRepository _PostRepository;

        public MagelanService(IPostRepository postRepository) {
            _PostRepository = postRepository;
        }

        public void AddPost(Posts newPost) {
            _PostRepository.Add(newPost);
            _PostRepository.SaveChanges();
        }

        public List<Posts> GetPosts() {
            return _PostRepository.GetAll() as List<Posts>;
        }
    }
}