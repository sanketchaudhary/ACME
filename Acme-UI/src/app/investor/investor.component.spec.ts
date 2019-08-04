/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
// import { By } from '@angular/platform-browser';
// import { DebugElement } from '@angular/core';

import { InvestorComponent } from './investor.component';
import { InvestorService } from './investor.service';

describe('InvestorComponent', () => {
  let component: InvestorComponent;
  let fixture: ComponentFixture<InvestorComponent>;
  let investorService: InvestorService;
  let checkStateAndPostcodeSpy;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [ InvestorComponent ]
    })
    .compileComponents();

    this.checkStateAndPostcodeSpy = spyOn(investorService, 'checkStateAndPostcode');
  });

  // beforeEach(() => {
  //   fixture = TestBed.createComponent(InvestorComponent);
  //   component = fixture.componentInstance;
  //   fixture.detectChanges();
  // });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should have State and Postcode values before comparing', () => {
    // Arrange
    component.investorFormGroup.controls['state'].setValue('');
    component.investorFormGroup.controls['postcode'].setValue('');
            
    // Act
    component.onStateAndPostcodeChange();

    // Assert
    expect(checkStateAndPostcodeSpy).not.toHaveBeenCalled();
  });

  it('should call service method for valid state and sostcode values for comparing', () => {
    // Arrange
    component.investorFormGroup.controls['state'].setValue('NSW');
    component.investorFormGroup.controls['postcode'].setValue('1234');
            
    // Act
    component.onStateAndPostcodeChange();

    // Assert
    expect(checkStateAndPostcodeSpy).toHaveBeenCalled();
  });
});
