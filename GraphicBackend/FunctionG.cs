using System.Reflection.Metadata;
using GraphicBackend;

public class FuctionG : Function
{
  private double a, b, c, d, e, f;
  //operation with in G(x) function (parameters[0]*x*x+parameters[1]*x+parameters[2])/(parameters[3]*x*x+parameters[4]*x+parameters[5]);
  public FuctionG(double[] parameters)
  {
    a = parameters[0];
    b = parameters[1];
    c = parameters[2];
    d = parameters[3];
    e = parameters[4];
    f = parameters[5];
  }
  public override double EvaluateX(double x)
  {
    if (IsInDomain(x))
    {
      double operation = (a * x * x + b * x + c) / (d * x * x + e * x + f); //parameters[0]-parameter[5]  Indicate the parameters organized alphabetically
      return operation;
    }
    return double.NaN;
  }
  protected override double EvaluateFirstDerivative(double x)
  {
    if (IsInFirstDerivativeDomain(x))
    {
      double operation = (2 * a * x + b) * (d * x * x + e * x + f) - (2 * d * x + e) * (a * x * x + b * x + c);
      double operation1 = (d * x * x + e * x + f) * (d * x * x + e * x + f);
      return operation / operation1;
    }
    return double.NaN;
  }
  protected override double EvaluateSecondDerivative(double x)
  {
    if (IsInSecondDerivativeDomain(x))
    {
      double operation = (b * d * d - e * a * d) * x * x * x;
      double operation1 = (3 * c * d * d - 3 * a * d * f) * x * x;
      double operation2 = (3 * e * c * d - 3 * d * b * f) * x;
      double operation3 = a * f * f + (-c * d - e * b) * f + e * e * c;
      double operation4 = (d * x * x + e * x + f) * (d * x * x + e * x + f) * (d * x * x + e * x + f);
      return (2 * operation + operation1 + operation2 + operation3) / operation4;
    }
    return double.NaN;
  }

  protected override void FindDomain()
  {
    double discriminant = e * e - 4 * d * f;
    if (discriminant < 0)
      Domain.Add((Double.NegativeInfinity, Double.PositiveInfinity));
    else if (discriminant == 0)
    {
      double row = (-b + Math.Sqrt(discriminant)) / 2 * d;
      Domain.Add((Double.NegativeInfinity, row));
      Domain.Add((row, Double.PositiveInfinity));
    }
    else
    {
      double row = (-b + Math.Sqrt(discriminant)) / 2 * d;
      double row1 = (-b - Math.Sqrt(discriminant)) / 2 * d;
      if (row > row1)
      {
        double a = row;
        row = row1;
        row1 = a;
      }
      Domain.Add((Double.NegativeInfinity, row));
      Domain.Add((row, row1));
      Domain.Add((row1, Double.PositiveInfinity));
    }
  }

}
