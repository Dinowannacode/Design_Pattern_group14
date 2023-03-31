package extractSubclass;

class JobItem{
    int getTotalPrice(){/** ... */}
    int getUnitPrice(){/** ... */}
}
/**
 * - Create new subclass LaborItem
 * - Move method getUnitPrice and getEmployee from now superclass JobItem
 * to subclass LaborItem
 * - Delete old field getEmployee from superclass
 */
class LaborItem extends JobItem	{
   int getUnitPrice(){/** ... */}
   String getEmployee(){/** ... */}
}