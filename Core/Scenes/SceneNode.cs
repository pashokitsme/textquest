using Core.Data;

namespace Core.Scenes
{
    public class SceneNode
    {
        public List<Answer> Answers => _connected;
        public ISceneData Data => _data;

        private readonly ISceneData _data;
        private readonly List<Answer> _connected = new();

        public SceneNode(ISceneData data, ISceneProvider provider, SceneNode parent = null)
        {
            _data = data;
            _connected = new List<Answer>();

            if (_data == null || _data.Answers == null)
                return;

            foreach (var answer in _data.Answers)
            {
                var ans = _connected.FirstOrDefault(x => x.NextScene.Data.Id == answer.NextSceneId);

                if (ans != null)
                {
                    _connected.Add(new Answer(answer.Body, ans.NextScene));
                    return;
                }

                var next = answer.NextSceneId switch
                {
                    "!parent" => parent,
                    _ => new SceneNode(provider.Load(answer.NextSceneId), provider, this)
                };

                _connected.Add(new Answer(answer.Body, next));
            }
        }

        public SceneNode Answer(Answer answer) => _connected.First(ans => ans == answer).NextScene;

        public void Draw(IView view) => view.Draw(_data);


    }
}
