namespace EnumeratorUtils

open System.Collections
open System.Runtime.CompilerServices

(*
// Not visible from C#

type IEnumerator with
    member this.Cast<'a>() =
        seq {
            while this.MoveNext() do yield this.Current
        }
        |> Seq.cast<'a>
*)

[<Extension>]
type Extensions =
    [<Extension>]
    static member Cast<'a>(datas: IEnumerator) =
        seq {
            while datas.MoveNext() do yield datas.Current
        } |> Seq.cast<'a>