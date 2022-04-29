using Serenity.Navigation;
using MyPages = SereneViewSample.ProjectMgnt.Pages;

[assembly: NavigationLink(int.MaxValue, "ProjectMgnt/Project", typeof(MyPages.ProjectController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMgnt/Project Add On", typeof(MyPages.ProjectAddOnController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMgnt/Project History", typeof(MyPages.ProjectHistoryController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMgnt/Project Members", typeof(MyPages.ProjectMembersController), icon: null)]
[assembly: NavigationLink(int.MaxValue, "ProjectMgnt/V Project", typeof(MyPages.VProjectController), icon: null)]