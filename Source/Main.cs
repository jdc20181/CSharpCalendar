
    public void ReloadCal(DateTime ldate, int Selected) {
        this.clearall();
        MonthName.Text = monthstr(ldate.Month);
        DayOfWeek fdate = GetFirstOfMonthDay(ldate);
        int idate = 1;
        int row = 1;
        for (
        ; // TODO: Warning!!!! NULL EXPRESSION DETECTED...
        ; 
        ) {
            getlabel(fdate, row).Text = idate;
            getlabel(fdate, row).ForeColor = Label1.ForeColor;
            if ((idate == Selected)) {
                getlabel(fdate, row).ForeColor = Color.Yellow;
            }
            
            if ((fdate == DayOfWeek.Saturday)) {
                row++;
            }
            
            fdate = tdate(fdate);
            idate++;
            (DaysInMonth(ldate.Year, ldate.Month) + 1);
            break; //Warning!!! Review that break works as 'Exit Do' as it could be in a nested instruction like switch
            clearall();
            su1.Text = "";
            su2.Text = "";
            su3.Text = "";
            su4.Text = "";
            su5.Text = "";
            su6.Text = "";
            m1.Text = "";
            m2.Text = "";
            m3.Text = "";
            m4.Text = "";
            m5.Text = "";
            m6.Text = "";
            tu1.Text = "";
            tu2.Text = "";
            tu3.Text = "";
            tu4.Text = "";
            tu5.Text = "";
            tu6.Text = "";
            w1.Text = "";
            w2.Text = "";
            w3.Text = "";
            w4.Text = "";
            w5.Text = "";
            w6.Text = "";
            th1.Text = "";
            th2.Text = "";
            th3.Text = "";
            th4.Text = "";
            th5.Text = "";
            th6.Text = "";
            f1.Text = "";
            f2.Text = "";
            f3.Text = "";
            f4.Text = "";
            f5.Text = "";
            f6.Text = "";
            sa1.Text = "";
            sa2.Text = "";
            sa3.Text = "";
            sa4.Text = "";
            sa5.Text = "";
            sa6.Text = "";
            ((System.Windows.Forms.Label)(getlabel(((DayOfWeek)(day)), ((int)(row)))));
            switch (day) {
                case DayOfWeek.Sunday:
                    switch (row) {
                        case 1:
                            return su1;
                            break;
                        case 2:
                            return su2;
                            break;
                        case 3:
                            return su3;
                            break;
                        case 4:
                            return su4;
                            break;
                        case 5:
                            return su5;
                            break;
                        case 6:
                            return su6;
                            break;
                    }
                    break;
                case DayOfWeek.Monday:
                    switch (row) {
                        case 1:
                            return m1;
                            break;
                        case 2:
                            return m2;
                            break;
                        case 3:
                            return m3;
                            break;
                        case 4:
                            return m4;
                            break;
                        case 5:
                            return m5;
                            break;
                        case 6:
                            return m6;
                            break;
                    }
                    break;
                case DayOfWeek.Tuesday:
                    switch (row) {
                        case 1:
                            return tu1;
                            break;
                        case 2:
                            return tu2;
                            break;
                        case 3:
                            return tu3;
                            break;
                        case 4:
                            return tu4;
                            break;
                        case 5:
                            return tu5;
                            break;
                        case 6:
                            return tu6;
                            break;
                    }
                    break;
                case DayOfWeek.Wednesday:
                    switch (row) {
                        case 1:
                            return w1;
                            break;
                        case 2:
                            return w2;
                            break;
                        case 3:
                            return w3;
                            break;
                        case 4:
                            return w4;
                            break;
                        case 5:
                            return w5;
                            break;
                        case 6:
                            return w6;
                            break;
                    }
                    break;
                case DayOfWeek.Thursday:
                    switch (row) {
                        case 1:
                            return th1;
                            break;
                        case 2:
                            return th2;
                            break;
                        case 3:
                            return th3;
                            break;
                        case 4:
                            return th4;
                            break;
                        case 5:
                            return th5;
                            break;
                        case 6:
                            return th6;
                            break;
                    }
                    break;
                case DayOfWeek.Friday:
                    switch (row) {
                        case 1:
                            return f1;
                            break;
                        case 2:
                            return f2;
                            break;
                        case 3:
                            return f3;
                            break;
                        case 4:
                            return f4;
                            break;
                        case 5:
                            return f5;
                            break;
                        case 6:
                            return f6;
                            break;
                    }
                    break;
                case DayOfWeek.Saturday:
                    switch (row) {
                        case 1:
                            return sa1;
                            break;
                        case 2:
                            return sa2;
                            break;
                        case 3:
                            return sa3;
                            break;
                        case 4:
                            return sa4;
                            break;
                        case 5:
                            return sa5;
                            break;
                        case 6:
                            return sa6;
                            break;
                    }
                    break;
            }
            ((DayOfWeek)(GetFirstOfMonthDay(((DateTime)(ThisDay)))));
            DayOfWeek tday = ThisDay.DayOfWeek;
            int tint = ThisDay.Day;
            if ((tint == 1)) {
                return tday;
                // TODO: Exit Function: Warning!!! Need to return the value
                return;
            }
            
            for (
            ; true; 
            ) {
                tint--;
                tday = ydate(tday);
                if ((tint == 1)) {
                    break; //Warning!!! Review that break works as 'Exit Do' as it could be in a nested instruction like switch
                }
                
            }
            
            return tday;
            ((DayOfWeek)(ydate(((DayOfWeek)(tday)))));
            DayOfWeek rday;
            switch (tday) {
                case DayOfWeek.Sunday:
                    rday = DayOfWeek.Saturday;
                    break;
                case DayOfWeek.Monday:
                    rday = DayOfWeek.Sunday;
                    break;
                case DayOfWeek.Tuesday:
                    rday = DayOfWeek.Monday;
                    break;
                case DayOfWeek.Wednesday:
                    rday = DayOfWeek.Tuesday;
                    break;
                case DayOfWeek.Thursday:
                    rday = DayOfWeek.Wednesday;
                    break;
                case DayOfWeek.Friday:
                    rday = DayOfWeek.Thursday;
                    break;
                case DayOfWeek.Saturday:
                    rday = DayOfWeek.Friday;
                    break;
            }
            return rday;
            ((DayOfWeek)(tdate(((DayOfWeek)(tday)))));
            DayOfWeek rday;
            switch (tday) {
                case DayOfWeek.Sunday:
                    rday = DayOfWeek.Monday;
                    break;
                case DayOfWeek.Monday:
                    rday = DayOfWeek.Tuesday;
                    break;
                case DayOfWeek.Tuesday:
                    rday = DayOfWeek.Wednesday;
                    break;
                case DayOfWeek.Wednesday:
                    rday = DayOfWeek.Thursday;
                    break;
                case DayOfWeek.Thursday:
                    rday = DayOfWeek.Friday;
                    break;
                case DayOfWeek.Friday:
                    rday = DayOfWeek.Saturday;
                    break;
                case DayOfWeek.Saturday:
                    rday = DayOfWeek.Sunday;
                    break;
            }
            return rday;
            ((string)(monthstr(((int)(month)))));
            switch (month) {
                case 1:
                    return "January";
                    break;
                case 2:
                    return "Febuary";
                    break;
                case 3:
                    return "March";
                    break;
                case 4:
                    return "April";
                    break;
                case 5:
                    return "May";
                    break;
                case 6:
                    return "June";
                    break;
                case 7:
                    return "July";
                    break;
                case 8:
                    return "August";
                    break;
                case 9:
                    return "September";
                    break;
                case 10:
                    return "October";
                    break;
                case 11:
                    return "November";
                    break;
                case 12:
                    return "December";
                    break;
            }
        }
        
    }
