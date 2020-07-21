namespace garys_garage
{
    public class Prius : GasPowered // NOOOOOO
    {

        // Oh no! We have a hybrid car. It's sometimes powered by gas and sometimes powered by battery. It should be able to park in either garage, and it needs properties of both a electric and a gas powered car. For instance, we need both fuel capacity AND battery kwh.

        // We can only inherit from one place at a time, so we're in a pickle. Ideally, we'd really want to use properties from both.

        // We could also have Prius inherit straight from Vehicle, instead of from GasPowered or Electric, but then we miss out on all the good stuff in those classes and we'd still be duplicating code.

    }
}