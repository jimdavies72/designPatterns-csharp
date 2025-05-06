// Client class - logic

namespace structuralDesignPatterns.src.CompositeWithAbstractComponent;

public class RunCompositeWithAbstractClass
{
  public static void RunCompositeWithAbstractClassPattern()
  {
    GitComponent mainBranch = new Branch("Main");

    GitComponent commitToMain1 = new Commit("82a79d4");
    GitComponent commitToMain2 = new Commit("96b27j8");
    GitComponent commitToMain3 = new Commit("12b27f9");
    GitComponent commitToMain4 = new Commit("32g45k0");

    mainBranch.Add(commitToMain1);
    mainBranch.Add(commitToMain2);
    mainBranch.Add(commitToMain3);
    mainBranch.Add(commitToMain4);

    //rollbac commit 4
    mainBranch.Remove(commitToMain4);

    GitComponent smallFeature = new Branch("Small Feature");
    mainBranch.Add(smallFeature);
    GitComponent commitToSmallFeature1 = new Commit("sf56h93");
    smallFeature.Add(commitToSmallFeature1);

    GitComponent bigFeature = new Branch("Big Feature");
    mainBranch.Add(bigFeature);
    GitComponent commitToBigFeature1 = new Commit("bf54l88");
    bigFeature.Add(commitToBigFeature1);  

    //mainBranch.ShowDetail();
    smallFeature.ShowDetail();
  }
}
