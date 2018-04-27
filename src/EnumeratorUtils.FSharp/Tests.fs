module Tests

open Xunit
open EnumeratorUtils

[<Fact>]
let ``My test`` () =
    let a = [1;2;3;4] |> Seq.ofList
    let e = a.GetEnumerator()
    let ee = e.Cast<int>()

    Assert.True([1;2;3;4] = (ee |> Seq.toList))