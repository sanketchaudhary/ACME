import { ValidatorFn, FormGroup } from "@angular/forms";

export function ValidateStateAndPostcode(formGroup: FormGroup) {
    var state = formGroup.controls['state'].value;
    var postcode = formGroup.controls['postcode'].value;
    if (state && postcode) {
        
      return { validUrl: true };
    }
    return null;
  }