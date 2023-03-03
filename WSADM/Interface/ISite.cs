﻿using WSADM.Interface;

namespace WSADM.Models;

public interface ISite
{
    public string Name { get; set; }
    public string PhysicalPath { get; set; }
    public string RunPath { get; set; }
    public IBindingInformationCollection BindingInformationCollection { get; set; }
}
