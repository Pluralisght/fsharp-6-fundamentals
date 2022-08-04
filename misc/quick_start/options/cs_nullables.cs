class SomeClass{}
class SomeResult{}

public SomeResult myFunction(SomeClass isThisNull){
    if (isThisNull == null)
        throw new System.Exception("Parameter isThisNull is Null");
    return null; // oops, making life hard for someone else
}

try {
    var someResult = myFunction(new SomeResult());
    if (someResult == null) throw new System.Exception("Hey, someone else deal with this");
    // actual code to do something
} catch (Esception ex) {
    throw ex; // again, someone else deal with this
}

int? x = null;
if (x.HasValue)
{
    // do something
} else {
    // take other action for missing
}

var actualValue = x.GetValueOrDefault()


[HttpPost] public IActionResult Put([FromBody] DtoModel request) {
    try
    {
        if (!validate(request)) return this.BadRequest("Validattion failed");
        if (!createInDb(request)) return this.BadRequest("Some error from the db");

        return Ok();
    }
    catch (Exception ex)
    {
        return this.Problem(ex.Message);
    }
}
