using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWeb.Models
{
    public class Roles
    {
        
        public int RoleID { get; set; }
        public bool CanAccessLibraryInfo { get; set; }
        public bool CanReserveItems { get; set; }
        public bool CanRegisterItems { get; set; }
        public bool CanModifyItemsInfo { get; set; }
        public bool CanRegisterBorrowing { get; set; }
        public bool CanRegisterReturning { get; set; }
        public bool CanModifyItemLocation { get; set; }
        public bool CanApproveReaderRegistration { get; set; }
        public bool CanManageUsers { get; set; }
        public bool CanChangeUserRoles { get; set; }

        public class UnregisteredUser:Roles
        {
            public Roles Role { get; }

            public UnregisteredUser()
            {
                Role = new Roles(canAccessLibraryInfo: true, canReserveItems: false, canRegisterItems: false,
                                 canModifyItemsInfo: false, canRegisterBorrowing: false, canRegisterReturning: false,
                                 canModifyItemLocation: false, canApproveReaderRegistration: false,
                                 canManageUsers: false, canChangeUserRoles: false);
            }
        }
        public class Reader:Roles
        {
            public Roles Role { get; }

            public Reader()
            {
                Role = new Roles(canAccessLibraryInfo: true, canReserveItems: true, canRegisterItems: false,
                                 canModifyItemsInfo: false, canRegisterBorrowing: false, canRegisterReturning: false,
                                 canModifyItemLocation: false, canApproveReaderRegistration: false,
                                 canManageUsers: false, canChangeUserRoles: false);
            }
        }
        public class Librarian:Roles
        {
            public Roles Role { get; }

            public Librarian()
            {
                Role = new Roles(canAccessLibraryInfo: true, canReserveItems: true, canRegisterItems: true,
                                 canModifyItemsInfo: true, canRegisterBorrowing: true, canRegisterReturning: true,
                                 canModifyItemLocation: true, canApproveReaderRegistration: false,
                                 canManageUsers: false, canChangeUserRoles: false);
            }
        }
        public class Administrator:Roles
        {
            public Roles Role { get; }

            public Administrator()
            {
                Role = new Roles(canAccessLibraryInfo: true, canReserveItems: true, canRegisterItems: true,
                                 canModifyItemsInfo: true, canRegisterBorrowing: true, canRegisterReturning: true,
                                 canModifyItemLocation: true, canApproveReaderRegistration: true,
                                 canManageUsers: true, canChangeUserRoles: true);
            }
        }
        public Roles()
        {
            // Empty constructor
        }

        public Roles(bool canAccessLibraryInfo, bool canReserveItems, bool canRegisterItems, bool canModifyItemsInfo,
                     bool canRegisterBorrowing, bool canRegisterReturning, bool canModifyItemLocation,
                     bool canApproveReaderRegistration, bool canManageUsers, bool canChangeUserRoles)
        {
            CanAccessLibraryInfo = canAccessLibraryInfo;
            CanReserveItems = canReserveItems;
            CanRegisterItems = canRegisterItems;
            CanModifyItemsInfo = canModifyItemsInfo;
            CanRegisterBorrowing = canRegisterBorrowing;
            CanRegisterReturning = canRegisterReturning;
            CanModifyItemLocation = canModifyItemLocation;
            CanApproveReaderRegistration = canApproveReaderRegistration;
            CanManageUsers = canManageUsers;
            CanChangeUserRoles = canChangeUserRoles;
        }
    }
}
