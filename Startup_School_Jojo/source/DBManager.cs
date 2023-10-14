namespace DateBaseLogic{
    public class DB
    {
        private static readonly List<Sample> samples = new();

        public void AddSample(Sample sample){
            samples.Add(sample);
        }
        public void AddSample(){
            samples.Add(new Sample(samples.Count + 1));
        }

        public void RemoveSample(int sample_id){
            var sample = samples.FirstOrDefault(sample => sample.Id == sample_id);
            if(sample is not null){
                samples.Remove(sample);
            }
        }
        private static readonly List<Plugin> plugins = new();

        public void AddPlugin(){
            Sample standart = new(samples.Count + 1);
            plugins.Add(new Plugin(plugins.Count + 1, standart.Id));
        }

        public Plugin GetPlugin(int plugin_id){
            return plugins.FirstOrDefault(p => p.Id == plugin_id);
        }

        public List<Plugin> GetPlugins(){
            return plugins;
        }
        public List<Sample> GetSamples(){
            return samples;
        }
        private static readonly List<Workspace> workspaces = new();

        public void AddWorkspace(Workspace workspace){
            workspaces.Add(workspace);
        }
        public void AddWorkspace(){
            workspaces.Add(new Workspace(workspaces.Count + 1));
        }

        public void RemoveWorkspace(int workspace_id){
            var workspace = workspaces.FirstOrDefault(workspace => workspace.Id == workspace_id);
            if(workspace is not null){
                workspaces.Remove(workspace);
            }
        }
        public List<Workspace> GetWorkspaces(){
            return workspaces;
        }

        public string GetGuid(int workspace_id){
            return workspaces.FirstOrDefault(workspace => workspace.Id == workspace_id).Guid_id;
        }
    }
}